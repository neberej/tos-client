using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace Adapter
{
    public interface IRtdClient
    {
        bool GetValue(TimeSpan timeout, out object value, params object[] args);
    }

    public class RtdClient : IRTDUpdateEvent, IRtdClient
    {

        readonly Guid ServerId;
        int Heartbeat;
        static readonly Dictionary<Guid, IRTDServer> servers = new Dictionary<Guid, IRTDServer>();
        static readonly Dictionary<Guid, int> topicIds = new Dictionary<Guid, int>();


        public RtdClient(Guid serverId, int heartbeat)
        {
            ServerId = serverId;
            Heartbeat = heartbeat;
        }

        public bool GetValue(TimeSpan timeout, out object value, params object[] args)
        {

            value = null;
            var server = GetRtdServer();
            var topicId = GetTopicId();

            var sw = Stopwatch.StartNew();
            var delay = 100;

            try
            {
                server.ConnectData(topicId, args, true);
                while (sw.Elapsed < timeout)
                {
                    Thread.Sleep(delay);
                    delay *= 2;
                    var alive = server.Heartbeat();
                    if (alive != 1)
                    {
                        Debug.WriteLine("ERROR!!!!");
                        return false;
                    }
                    var refresh = server.RefreshData(1);
                    if (refresh.Length > 0)
                    {
                        if (refresh[0, 0].ToString() == topicId.ToString())
                        {
                            value = refresh[1, 0];
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                server.DisconnectData(topicId);
                sw.Stop();
            }
            return false;
        }


        public void UpdateNotify()
        {
            var server = GetRtdServer();
            var topicId = GetTopicId();
            var refresh = server.RefreshData(1);
            if (refresh.Length > 0)
            {
                for (int i = 0; i < refresh.Length / 2; i++)
                {
                    var id = (int)refresh[0, i];
                    Debug.WriteLine("update...", i);
                    //var data = this.topics.Get(id);
                    //this.queue.Push(new Quote(
                    //    data.Item1,
                    //    data.Item2,
                     //   double.Parse(refresh[1, i].ToString())));
                }
            }
        }


        public int HeartbeatInterval
        {
            get; set;
        }

        public void Disconnect()
        {
            //this.queue.Disconnect();
        }


        IRTDServer GetRtdServer()
        {
            IRTDServer server;
            if (!servers.TryGetValue(ServerId, out server))
            {
                Type rtd = Type.GetTypeFromCLSID(ServerId);
                server = (IRTDServer)Activator.CreateInstance(rtd);
                servers[ServerId] = server;
            }
            return server;
        }

        int GetTopicId()
        {
            int topicId = 0;
            if (topicIds.TryGetValue(ServerId, out topicId))
            {
                topicId++;
            }
            topicIds[ServerId] = topicId;
            return topicId;
        }
    }
}
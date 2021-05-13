using System;
using System.Collections.Generic;

namespace Singleton_Example.Singleton
{
    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    class LoadBalancer
    {
        private static LoadBalancer _instance;
        private readonly List<string> _servers = new();
        private readonly Random _random = new();

        // Lock synchronization object
        private static readonly object SyncLock = new();

        // Constructor (protected)
        protected LoadBalancer()
        {
            // List of available servers
            _servers.Add("Server Iran");
            _servers.Add("Server Germany");
            _servers.Add("Server English");
            _servers.Add("Server Turkey");
            _servers.Add("Server Russia");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            // Support multi threaded applications through
            // 'Double checked locking' pattern which (once
            // the instance exists) avoids locking each
            // time the method is invoked
            if (_instance is null)
            {
                lock (SyncLock)
                {
                    _instance ??= new();
                }
            }

            return _instance;
        }

        // Simple, but effective random load balancer
        public string Server
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }
}

// Copyright 2016 Tom Deseyn <tom.deseyn@gmail.com>
// This software is made available under the MIT License
// See COPYING for details

using System;
using System.Threading;

namespace Tmds.DBus
{
    public class ConnectionOptions
    {
        public SynchronizationContext SynchronizationContext { get; set; }
        public bool AutoConnect { get; set; }
    }
}
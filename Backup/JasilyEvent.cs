﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class JasilyEvent
    {
        public static void Fire(this EventHandler e, object sender, EventArgs args = null)
        {
            if (e != null)
                e(sender, args);
        }

        public static void Fire<T>(this EventHandler<T> e, object sender, T args)
        {
            if (e != null)
                e(sender, args);
        }
    }
}
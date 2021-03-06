﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistributeObject
{
    public class CPTBacHai : ClientObject
    {
        public override string GetClassName()
        {
            return "PTBacNhat";
        }

        public float a
        {
            get
            {
                return (float)ClientObjectManager.GetAttributeValue(Handle, "A");
            }
            set
            {
                ClientObjectManager.SetAttributeValue(Handle, "A", value);
            }
        }
        public float b
        {
            get
            {
                return (float)ClientObjectManager.GetAttributeValue(Handle, "B");
            }
            set
            {
                ClientObjectManager.SetAttributeValue(Handle, "B", value);
            }
        }
        public float c
        {
            get
            {
                return (float)ClientObjectManager.GetAttributeValue(Handle, "C");
            }
            set
            {
                ClientObjectManager.SetAttributeValue(Handle, "C", value);
            }
        }
        public string[] Solve()
        {
            return (string[])ClientObjectManager.ExecuteFunction(Handle, "Solve", null);
        }
    }
}
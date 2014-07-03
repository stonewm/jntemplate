﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JinianNet.JNTemplate.Parser.Node
{
    public class TextTag : SimpleTag
    {
        public override Object Parse(TemplateContext context)
        {
            return this.ToString();
        }

        public override Object Parse(Object baseValue, TemplateContext context)
        {
            return this.ToString();
        }

        public override void Parse(TemplateContext context, System.IO.TextWriter write)
        {
            write.Write(this.ToString());
        }
    }
}
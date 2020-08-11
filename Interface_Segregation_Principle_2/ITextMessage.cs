using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle_2
{
    interface ITextMessage : IMessage
    {
        string Text { get; set; }
    }
}
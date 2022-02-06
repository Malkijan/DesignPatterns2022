using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Memento
{
     class TextMemento
    {
        // Saklamak istediğimiz değerlerin tanımlandığı yerdir.
        public string Text { get; set; }
        public int CursorPosition { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Memento
{
    // Değerleri tutulacak olan ve önceki değerlerine geri dönebilen sınıftır.
    // Geriye dönebilme özelliği olduğundan önceki durumları tutan CareTaker referansını tutmaktadır.
     class TextOriginator
    {
        public string Text { get; set; }
        public int CursorPosition { get; set; }

        private TextUndoCareTaker _textCareTaker;

        public TextOriginator()
        {
            _textCareTaker = new TextUndoCareTaker();
        }

        public void Save()
        {
            _textCareTaker.TextMemento = new TextMemento
            {
                CursorPosition = this.CursorPosition,
                Text = this.Text
            };
        }

        public void Undo()
        {
            TextMemento previousTextMemento = _textCareTaker.TextMemento;

            CursorPosition = previousTextMemento.CursorPosition;
            Text = previousTextMemento.Text;
        }
        public override string ToString()
        {
            return $"text: {Text}, cursor position: {CursorPosition}";
        }
    }
}

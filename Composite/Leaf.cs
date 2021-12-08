using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    // Класс Лист представляет собой конечные объекты структуры. Лист не может
    // иметь вложенных компонентов.
    //
    // Обычно объекты Листьев выполняют фактическую работу, тогда как объекты
    // Контейнера лишь делегируют работу своим подкомпонентам.
    class Leaf : Component
    {
        public override string Operation()
        {
            return "Лист";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }

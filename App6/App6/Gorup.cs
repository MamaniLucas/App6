using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App6
{
    class Gorup : ObservableCollection<Estudiante>

    {
        public Gorup(String firstInitial) {

            FirstInitial = firstInitial;

        }
        public string FirstInitial
        {
            get;
            private set;
        }
    }
}

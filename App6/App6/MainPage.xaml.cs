using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App6
{
    public partial class MainPage : ContentPage
    {

        public class Grouping<K, T> : ObservableCollection<T>
        {
            public K Key { get; private set; }

            public Grouping(K key, IEnumerable<T> items)
            {
                Key = key;
                foreach (var item in items)
                {
                    Add(item);
                }
            }
        }

        public MainPage()
        {
            InitializeComponent();

            // Define una lista de estudiantes
            List<Estudiante> estudiantes = new List<Estudiante>
            {
                new Estudiante { Nombres = "Juan", Apellidos = "Pérez", Edad = 20 },
                new Estudiante { Nombres = "María", Apellidos = "Gómez", Edad = 22 },
                new Estudiante { Nombres = "Luis", Apellidos = "Rodríguez", Edad = 21 },
                new Estudiante { Nombres = "Ana", Apellidos = "Sánchez", Edad = 19 },
                new Estudiante { Nombres = "Pedro", Apellidos = "López", Edad = 20 },
                new Estudiante { Nombres = "Sofía", Apellidos = "Martínez", Edad = 22 },
            };

            // Agrupa los estudiantes por sección
            var estudiantesA = estudiantes.Where(e => e.Nombres.StartsWith("A")).ToList();
            var estudiantesB = estudiantes.Where(e => e.Nombres.StartsWith("B")).ToList();

            // Crea una lista de grupos
            var grupos = new List<Grouping<string, Estudiante>>
            {
                new Grouping<string, Estudiante>("Sección A", estudiantesA),
                new Grouping<string, Estudiante>("Sección B", estudiantesB),
            };

            // Asigna la lista de grupos como origen de datos para la ListView
            listView.ItemsSource = grupos;
        }
    }
}

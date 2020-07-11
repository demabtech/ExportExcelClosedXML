using ExportExcel.Models;
using System.Collections.Generic;

namespace ExportExcel.Services
{
    public class ProductService
    {
        public static IEnumerable<Product> Get() =>
            new List<Product>()
            {
                new Product{Id = 1, Name="Portátil HP Envy Laptop", Description ="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris luctus bibendum venenatis. Nullam id nisl et enim egestas porta.", Stock = 2, Price = 700 },
                new Product{Id = 2, Name="PC Gamer Asus TUF Gaming", Description ="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris luctus bibendum venenatis. Nullam id nisl et enim egestas porta.", Stock = 1, Price = 900 },
                new Product{Id = 3, Name="Ipad séptima generación 10.2", Description ="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris luctus bibendum venenatis. Nullam id nisl et enim egestas porta.", Stock = 4, Price = 500 },
                new Product{Id = 4, Name="Multifuncional Ecotank L3110", Description ="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris luctus bibendum venenatis. Nullam id nisl et enim egestas porta.", Stock = 3, Price = 200 },
                new Product{Id = 5, Name="Mouse R.A.T 8+ GAMING Negro", Description ="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris luctus bibendum venenatis. Nullam id nisl et enim egestas porta.", Stock = 5, Price = 50 },
                new Product{Id = 6, Name="Control Dualshock4 Sony", Description ="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris luctus bibendum venenatis. Nullam id nisl et enim egestas porta.", Stock = 8, Price = 150 },
                new Product{Id = 7, Name="Control inalámbrico para xbox 360-negro", Description ="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris luctus bibendum venenatis. Nullam id nisl et enim egestas porta.", Stock = 2, Price = 130 },
                new Product{Id = 8, Name="Audífonos HyperX HX-HSCSC2", Description ="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris luctus bibendum venenatis. Nullam id nisl et enim egestas porta.", Stock = 20, Price = 70 },
                new Product{Id = 9, Name="Vídeo Juego Portátil - Retro 400", Description ="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris luctus bibendum venenatis. Nullam id nisl et enim egestas porta.", Stock = 12, Price = 40 },
            };
    }
}

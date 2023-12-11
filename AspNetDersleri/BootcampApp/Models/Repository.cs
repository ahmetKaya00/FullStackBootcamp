namespace BootcampApp.Models{

    public class Repository{

        private static readonly List<Bootcamp> _bootcamp = new();

        static Repository(){

            _bootcamp = new List<Bootcamp>(){
            new Bootcamp(){Id = 1, Title="Full Stack Bootcamp",Image="1.jpg", Description="Html, css, jacaScrip ve asp net dersleri", Tags = new string[] {"html","css","aspnet core"}, isActive = true,isHome=true},
            new Bootcamp(){Id = 2, Title="Game Bootcamp",Image="2.jpg", Description="Unity ile mobil oyun geliştirme", Tags = new string[] {"unity","c#","mobil"}, isActive = true,isHome=true},
            new Bootcamp(){Id = 3, Title="SQL Bootcamp",Image="3.jpg", Description="Sql server kullanarak data da geliş.", Tags = new string[] {"sql server","tsql"}, isActive = false,isHome=true},
            new Bootcamp(){Id = 4, Title="Backend Bootcamp",Image="4.jpg", Description="Web geliştir arka planda", isActive = true,isHome=false}
            };
        }
        public static List<Bootcamp> Bootcamps{
            get{
                return _bootcamp;
            }
        }

        public static Bootcamp? GetById(int? id){
            return _bootcamp.FirstOrDefault(b => b.Id == id);
        }


    }
}
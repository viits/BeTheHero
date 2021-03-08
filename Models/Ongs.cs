namespace Projeto.Models
{
    public class Ongs
    {
        public Ongs()
        {

        }
        public Ongs(int id, string name, string city, string uf, string wpp, string email)
        {
            this.Id = id;
            this.Name = name;
            this.City = city;
            this.Uf = uf;
            this.WhatsApp = wpp;
            this.Email = email;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Uf { get; set; }
        public string WhatsApp { get; set; }
        public string Email { get; set; }
    }
}
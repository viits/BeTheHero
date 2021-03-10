using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Projeto.Models
{
    public class Ongs
    {
        public Ongs( string name, string city, string uf, string WhatsApp, string email)
        {
            this.Name = name;
            this.City = city;
            this.Uf = uf;
            this.WhatsApp = WhatsApp;
            this.Email = email;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Uf { get; set; }
        public string WhatsApp { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public List<Incident> Incidents { get; set; }
    }
}
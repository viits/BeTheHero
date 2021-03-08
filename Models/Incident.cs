using System.Collections.Generic;

namespace Projeto.Models
{
    public class Incident
    {
        public Incident()
        {

        }
        public Incident(int id, string title, string desc, double value, int OngId)
        {
            this.Id = id;
            this.Title = title;
            this.Description = desc;
            this.Value = value;
            this.OngId = OngId;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public int OngId { get; set; }
        public Ongs Ongs { get; set; }
    }
}
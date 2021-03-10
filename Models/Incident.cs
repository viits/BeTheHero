using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.Models
{
    public class Incident
    {
        public Incident(int id, string title, string description, double value, int ongsId)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Value = value;
            this.OngsId = ongsId;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        
        public int OngsId{ get; set; }
        public Ongs Ongs { get; }
    }
}
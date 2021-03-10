using System.Collections.Generic;

namespace Projeto.Dtos
{
    public class IncidentDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string  Description { get; set; }
        public double Value { get; set; }
        public IEnumerable<OngDTO> OngsDTO { get; set; }
    }
}
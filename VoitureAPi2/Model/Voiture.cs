using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VoitureApi.Model;

namespace VoitureAPi2.Model
{
    public class Voiture
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateCerculation { get; set; }
        public string Image { get; set; }
        [ForeignKey("categorie")]
        public int IdCategorie { get; set; }
        public Categorie categorie { get; set; }
    }
}

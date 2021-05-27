using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetUdemy.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}

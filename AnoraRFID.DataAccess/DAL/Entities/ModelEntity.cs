using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnoraRFID.DataAccess.DAL.Entities
{
    public class ModelEntity : BaseEntity
    {
        public ModelEntity() : base()
        {

        }

        [Key]
        public int MODEL_ID { get; set; }

        [StringLength(100)]
        public string MODEL_NAME { get; set; }
    }
}

using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Model : Entity<Guid>
{
    public Guid BrandId { get; set; }
    public int FuelId { get; set; }
    public string Name { get; set; }
    public decimal DailyPrice { get; set; }
    public string ImageUrl { get; set; }
    public virtual Brand? Brand { get; set; }
    public virtual Fuel? Fuel { get; set; }
}

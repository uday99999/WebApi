using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApi.Models
{
    public class PaymentDetailContext: DbContext
    {               //constrcutor
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options) : base(options)///ctor double tb
        {

        }
            public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
    }


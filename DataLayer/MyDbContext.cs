using System;
using Microsoft.
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using PaymentGateway.Models;

namespace PaymentGateway.DataLayer
{
    public class MyDbContext : IdentityDbContext<Merchant>
    {

    }
}

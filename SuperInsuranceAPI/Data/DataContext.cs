﻿using Microsoft.EntityFrameworkCore;

namespace SuperInsuranceAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<SuperInsurance> SuperInsurances => Set<SuperInsurance>();
    }
}

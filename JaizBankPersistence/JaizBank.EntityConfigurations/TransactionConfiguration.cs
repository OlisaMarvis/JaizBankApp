using JaizBankDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaizBankPersistence.JaizBank.EntityConfigurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transactions>
    {
        public void Configure(EntityTypeBuilder<Transactions> builder)
        {
            builder.HasKey(x => x.TransactionId);
            builder.Property(x => x.MerchantName).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Amount).HasPrecision(20, 2);
            builder.Property(x => x.DebitCardNo).HasMaxLength(16).IsRequired();

            builder.HasData(
                new Transactions
                {
                    TransactionId = Guid.NewGuid(),
                    MerchantName = "LIZPEE GLOBAL RESOURCES",
                    Location = "NO, 174 NTA/MBUORA RD, PORTHARCOURT",
                    TerminalID = "23011845",
                    STAN = 003862,
                    DateTime = DateTime.Parse("2022/08/30 13:45:00"),
                    ExpiryDate = "11/24",
                    Amount = 0.01m,
                    DebitCardNo = "539941******3369",
                    AuthorizationCode = "000000",
                    ResponseCode = 91,
                    AID = "A0000000041010",
                    RRN = 000210002450,
                    PTAD = "Global Accelerex"
                });
        }
    }
}

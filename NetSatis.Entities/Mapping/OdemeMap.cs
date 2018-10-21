using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Tables;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetSatis.Entities.Mapping
{
    public class OdemeMap:EntityTypeConfiguration<OdemeTuru>
    {
        public OdemeMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.OdemeTuruKodu).HasMaxLength(12);
            this.Property(p => p.OdemeTuruAdi).HasMaxLength(30);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("OdemeTurleri");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.OdemeTuruKodu).HasColumnName("OdemeTuruKodu");
            this.Property(p => p.OdemeTuruAdi).HasColumnName("OdemeTuruAdi");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}

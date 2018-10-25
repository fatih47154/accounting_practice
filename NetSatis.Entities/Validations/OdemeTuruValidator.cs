﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class OdemeTuruValidator : AbstractValidator<OdemeTuru>
    {
        public OdemeTuruValidator()
        {
            RuleFor(p => p.OdemeTuruKodu).Empty().WithMessage("Ödeme Türü Kodu Alanı Boş Geçilemez");
            RuleFor(p => p.OdemeTuruAdi).Empty().WithMessage("Ödeme Türü Adı Alanı Boş Geçilemez");
        }
    }
}

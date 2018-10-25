using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class TanimValidator : AbstractValidator<Tanim>
    {
        public TanimValidator()
        {
            RuleFor(p => p.Turu).Empty().WithMessage("Tanım Türü Alanı Boş Geçilemez");
            RuleFor(p => p.Tanimi).Empty().WithMessage("Tanımı Alanı Boş Geçilemez");
        }
    }
}

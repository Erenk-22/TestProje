using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.ValidationRules
{
    public class KayitISlemValidator:AbstractValidator<KayitSistemi>
    {
        public KayitISlemValidator()
        {
            RuleFor(x => x.UyeAdi).NotNull().WithMessage("Boş Geçilemez!");
            RuleFor(x => x.UyeSoyadi).NotNull().WithMessage("Boş Geçilemez!");
            RuleFor(x => x.UyeTelefon).NotNull().WithMessage("Boş Geçilemez!");
            RuleFor(x => x.UyeMail).NotNull().WithMessage("Boş Geçilemez!");
            RuleFor(x => x.Sifre).NotNull().WithMessage("Boş Geçilemez!");
            RuleFor(x => x.UyeDogümTarihi).NotNull().WithMessage("Boş Geçilemez!");

        }
    }
}

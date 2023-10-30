using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class KargoValidator : AbstractValidator<Kargo>
    {
        //KURAL BELİRLE ME EKRANI
        public KargoValidator()
        {
            RuleFor(p => p.AlıcıAdSoyad).NotEmpty().WithMessage("Bu alan boş geçilemez");
                 

        }

     
    }
}

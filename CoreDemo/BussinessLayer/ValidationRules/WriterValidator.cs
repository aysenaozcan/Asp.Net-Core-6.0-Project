using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
	public class WriterValidator:AbstractValidator<Writer>
	{
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez");
			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az iki karakter girişi yapın");
			RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla elli karakter girişi yapın");
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar mail adresi kısmı boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez");
            
        }
    }
}

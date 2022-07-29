using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje adı boş geçilemez").MinimumLength(5).WithMessage("Proje adı en az 5 karakter olmalıdır");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim alanı boş geçilemez");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Resim alanı boş geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat alanı boş geçilemez");

        }
    }
}

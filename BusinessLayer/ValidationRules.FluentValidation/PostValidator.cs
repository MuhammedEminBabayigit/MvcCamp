using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class PostValidator : AbstractValidator<Post>
    {
        public PostValidator()
        {
            RuleFor(x => x.PostHead).NotEmpty().WithMessage("Post Başlığı Boş Geçilemez");
            RuleFor(x => x.PostContent).MinimumLength(10).WithMessage("Post İçeriği Minimum 10 karakter Olmalıdır");
        }
    }
}

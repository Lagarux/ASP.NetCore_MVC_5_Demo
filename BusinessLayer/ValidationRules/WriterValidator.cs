using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x=>x.WriterName).NotNull().WithMessage("Yazar adı soyadı kısmı boş geçilemez");
            RuleFor(x => x.WriterMail).NotNull().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.WriterPassword).NotNull().WithMessage("Şifre boş geçilemez");
            RuleFor(x => x.WriterAbout).NotNull().WithMessage("Yazar ile ilgili açıklama boş geçilemez");
            RuleFor(x => x.WriterAbout).NotNull().WithMessage("Yazar ile ilgili açıklama boş geçilemez");
            RuleFor(x=>x.WriterConfirmPassword).Matches(x=>x.WriterPassword).WithMessage("Şifreniz eşleşmiyor, lütfen tekrar deneyiniz");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterli bir isim giriniz");
            RuleFor(x => x.WriterPassword).Matches(@"[A-Z]+").WithMessage("Şifrede en az 1 büyük harf olmalı");
            RuleFor(x => x.WriterPassword).Matches(@"[a-z]+").WithMessage("Şifrede en az 1 küçük harf olmalı");
            RuleFor(x => x.WriterPassword).Matches(@"[0-9]+").WithMessage("Şifrede en az 1 rakam olmalı");
            RuleFor(x => x.WriterPassword).Matches(@"[][""!@$%^&*(){}:;<>,.?/+_=|'~\\-]+").WithMessage("Şifrenizde özel karakterler olmalı");
        }
    }
}

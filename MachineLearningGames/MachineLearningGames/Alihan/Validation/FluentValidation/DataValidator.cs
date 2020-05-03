using System.Data;
using FluentValidation;
using MachineLearningGames.Alihan.Entity;

namespace MachineLearningGames.Alihan.Validation.FluentValidation
{
    public class DataValidator : AbstractValidator<Customer>
    {
        public DataValidator()
        {
            RuleFor(x => x.Age).GreaterThan(0)
                .WithMessage("Lütfen yaş bilgisi kısmını kontrol ediniz!")
                .NotNull().WithMessage("Yaş bilgisi boş olmamalı");
            RuleFor(x => x.Embarked).NotEmpty().WithMessage("Lütfen gidilecek yeri seçiniz!");
            RuleFor(x => x.Gender).NotEmpty().WithMessage("Lütfen cinsiyet bilgisini seçiniz");
            RuleFor(x => x.ParentOrChildren).GreaterThan(-1).WithMessage("Lütfen ebeveyn ya da çocuk sayısını giriniz").NotNull().WithMessage("Lütfen ebeveyn ya da çocuk sayısını boş bırakmayınız");
            RuleFor(x => x.SiblingsOrSpouse).GreaterThan(-1)
                .WithMessage("Lütfen kardeş ya da eş sayısı giriniz!").NotNull().WithMessage("Kardeş ya da eş sayısı bilgisi boş olmamalı");
            RuleFor(x => x.TicketClass).NotEmpty().WithMessage("Lütfen bilet sınıfı bilgisini seçiniz!");
            RuleFor(x => x.TicketFare).GreaterThan(-1)
                .WithMessage("Lütfen bilet ücreti bilgisini kontrol ediniz").NotNull().WithMessage("Bilet ücreti bilgisi boş olmamalı");

        }
    }
}

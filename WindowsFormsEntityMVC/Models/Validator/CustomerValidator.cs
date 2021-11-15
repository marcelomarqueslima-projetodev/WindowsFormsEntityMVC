using FluentValidation;

namespace WindowsFormsEntityMVC.Models.Validator
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().Length(2,250).WithMessage("Necessário no mínimo 2 caracteres e no máximo 250 caracteres");
            RuleFor(x => x.Sobrenome).NotEmpty().Length(2, 250).WithMessage("Necessário no mínimo 2 caracteres e no máximo 250 caracteres");
            RuleFor(x => x.Cidade).NotEmpty().Length(2, 250).WithMessage("Necessário no mínimo 2 caracteres e no máximo 250 caracteres");
            RuleFor(x => x.Endereco).NotEmpty().Length(2, 250).WithMessage("Necessário no mínimo 2 caracteres e no máximo 250 caracteres");
        }
    }
}

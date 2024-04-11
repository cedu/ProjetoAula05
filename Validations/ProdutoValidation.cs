using FluentValidation;
using ProjetoAula05.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Validations
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(p => p.Id)
                .NotEmpty()
                .WithMessage("O id do produto é obrigatório");

            RuleFor(p => p.Nome)
                .NotEmpty()
                .WithMessage("O nome do produto é obrigatório")
                .Length(8, 100)
                .WithMessage("O nome do produto deve ter de 8 a 100 caracteres");


            RuleFor(p => p.Quantidade)
                .NotEmpty()
                .WithMessage("A quantidade do produto é obrigatório")
                .GreaterThanOrEqualTo(0)
                .WithMessage("A quantidade do produto deve ser maior ou igual a zero");

            RuleFor(p => p.Preco)
                .NotEmpty()
                .WithMessage("O preço do produto é obrigatório")
                .GreaterThan(0)
                .WithMessage("O preço do produto deve ser maior do que zero");

            RuleFor(p => p.Status)
                .NotEmpty()
                .WithMessage("O status do produto é obrigatório");
        }
    }
}

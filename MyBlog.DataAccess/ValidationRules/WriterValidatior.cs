using FluentValidation;
using MyBlog.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccess.ValidationRules
{
    public class WriterValidatior : AbstractValidator<Writer>
    {
        public WriterValidatior()
        {
            RuleFor(wr => wr.Name).NotEmpty().WithMessage("Name is not empty!");
            RuleFor(wr => wr.Email).NotEmpty().WithMessage("Email is not empty!");
            RuleFor(wr => wr.Password).NotEmpty().WithMessage("Password is not empty!");
            RuleFor(wr => wr.Name).MinimumLength(2).WithMessage("Name should be min 2 characters!");
            RuleFor(wr => wr.Name).MaximumLength(50).WithMessage("Name should be max 50 characters!");
        }
    }
}
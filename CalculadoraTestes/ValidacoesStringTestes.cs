using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTestes
    {
        private ValidacoesString _validacoes;
    
        public ValidacoesStringTestes()
        {
            _validacoes = new ValidacoesString();
        }

        [Fact]
        public void Contar3CaracterEmOlaERetornar()
        {
            // Given
            string teste1 = "ola";
            // When
            int res = _validacoes.ContarCaracteres(teste1);
            // Then
            Assert.Equal(3, res);
        }
    }
}
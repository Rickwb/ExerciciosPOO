// See https://aka.ms/new-console-template for more information
using ExerciciosPOO.Ecommerce;
using ExerciciosPOO;
int[] n = { 1, 2, 4, 5, 798, 547 };


//string []s =n.ToArrayString();
//for (int i = 0; i < s.Length; i++)
//{
//    Console.WriteLine(s[i].GetType());
//}

//Console.WriteLine("Hello, World!");
//string frase = "minha frase normal";
//frase = frase.ReverterFrase();
//Console.WriteLine(frase);
Pessoa p = new Pessoa();
Pessoa p1= new Pessoa();
Console.WriteLine(p.Equals(p));
 Console.WriteLine(p==p1);

string s = "áàÊêôèé";
s = s.RemoverAcentos();
Console.WriteLine(s);

//int[] vs = { 10, 15, 25, 32, 8, 4, 7, 1, 66, 4 };
//vs = vs.OrdenarInteiros();
//vs.ToList().ForEach(x => Console.WriteLine(x));
var cli =new Cliente();
cli.Nome = "Joao";
cli.Cpf = "0163513148469";
cli.Id = 100;
cli.Idade = 18;
var pe = new Pedido(cli);

var produto=new Produto();
produto.Nome = "Iphone";
produto.Foto = "fnndjsagbiqwernkvavlebooifcnd";
produto.Estoque = 12;
produto.Valor = 15;
produto.ID = 17;
pe.TipoPagamento = new CartaoCredito(Pagamento.Epagamento.Pix,15,DateTime.Now.AddDays(5),"156165","4684648","45646","Visa","123");

//produto.Medida = new Medidas();
pe.AdicionarProduto(produto);

Console.WriteLine(pe.ToString());





using ExercicioPOO;

//* 1. Sistema de veículos

// Carro carro = new Carro();
// carro.Modelo = "Voyage";
// carro.QuantidadePortas = 4;

// Motocicleta motocicleta = new Motocicleta();
// motocicleta.Modelo = "Kawasaki Ninja";
// motocicleta.Cilindradas = 300;

// Console.WriteLine("Carro:");
// Console.WriteLine($"Modelo: {carro.Modelo}");
// Console.WriteLine($"Quantidade de Portas: {carro.QuantidadePortas}");

// Console.WriteLine("\nMotocicleta:");
// Console.WriteLine($"Modelo: {motocicleta.Modelo}");
// Console.WriteLine($"Cilindradas: {motocicleta.Cilindradas}");

//* 2. Sistema de produtos digitais

// Ebook ebook = new Ebook("pai rico, pai pobre", 20, 180);
// CursoOnline curso = new CursoOnline("desenvolvimento de sistemas", 0, 2400);

//* 3. Sistema de jogos

// JogoDigital jogoDigital = new JogoDigital();

// jogoDigital.Nome = "Fortnite";
// jogoDigital.ExibirInformacoes("PC", "Terror", 111);

// JogoFisico jogoFisico = new JogoFisico();

// jogoFisico.Nome = "FIFA 23";
// jogoFisico.ExibirInformacoes("PS5", "Esporte", 222);

//* 4. Sistema de notificações

// NotificacaoEmail notificacaoEmail = new NotificacaoEmail();
// notificacaoEmail.Enviar("Olá, esta é uma notificação por e-mail.");

// NotificacaoSMS notificacaoSMS = new NotificacaoSMS();
// notificacaoSMS.Enviar("Olá, esta é uma notificação por SMS.");

// NotificacaoPush notificacaoPush = new NotificacaoPush();
// notificacaoPush.Enviar("Olá, esta é uma notificação por Push.");
// notificacaoPush.Enviar(""); // Testando envio de mensagem vazia

//* 5. Sistema de cálculo de frete

// List<Entrega> entregas = new List<Entrega>();

// entregas.Add(new EntregaExpressa());
// entregas.Add(new EntregaEconomica());
// entregas.Add(new RetiradaLocal());


// foreach (var entrega in entregas)
// {
//     entrega.CalcularFrete(10);
// }

//* 6. Sistema de documentos

// Relatorio relatorio = new Relatorio();
// relatorio.Imprimir();
// relatorio.Exportar();

// Contrato contrato = new Contrato();
// contrato.Imprimir();
//! contrato.Exportar(); // Contrato não tem o método Exportar da interface IExportavel

//* 7. Sistema de equipamentos

// Notebook notebook = new Notebook("G15", 123456, 16);
// notebook.ExibirInformacoes();

// Smartphone smartphone = new Smartphone("iPhone 13", 987654, 128);
// smartphone.ExibirInformacoes(); 

// * 8. Sistema de animais

// List<Animal> animais = new List<Animal>();

// animais.Add(new Cachorro("Rex"));
// animais.Add(new Gato("Mingau"));
// animais.Add(new Passaro("Pardal"));

// foreach (var animal in animais)
// {
//     animal.Apresentar();
//     animal.EmitirSom();
// }

//* 9. Sistema de armazenamento

// IArmazenavel armazenavel = new ArquivoTexto();
// armazenavel.Salvar("Conteúdo do arquivo de texto");
// armazenavel.Ler();

// IArmazenavel armazenavel1 = new BancoDados();
// armazenavel1.Salvar("Conteúdo do banco de dados");
// armazenavel1.Ler();

//* 10. Sistema de serviços

// IContratavel hospedagem = new Hospedagem();
// hospedagem.Contratar();

// IContratavel consultoria = new Consultoria();
// consultoria.Contratar();

// ICancelavel cancelavel = new Hospedagem();
// cancelavel.Cancelar();

//! ICancelavel cancelavel1 = new Consultoria();
//! cancelavel1.Cancelar(); // Erro: Consultoria não funciona porque não implementa a interface ICancelavel
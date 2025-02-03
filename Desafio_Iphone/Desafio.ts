// Interface para o Reprodutor Musical
interface ReprodutorMusical {
    void tocar();
    void pausar();
    void selecionarMusica(String musica);
}

// Interface para o Aparelho Telefônico
interface AparelhoTelefonico {
    void ligar(String numero);
    void atender();
    void iniciarCorreioDeVoz();
}

// Interface para o Navegador na Internet
interface NavegadorInternet {
    void exibirPagina(String url);
    void adicionarNovaAba();
    void atualizarPagina();
}

// Classe que representa o iPhone, implementando as interfaces
public class IPhone implements ReprodutorMusical, AparelhoTelefonico, NavegadorInternet {
    // Implementação dos métodos para Reprodutor Musical
    @Override
    public void tocar() {
        System.out.println("Reproduzindo música...");
    }

    @Override
    public void pausar() {
        System.out.println("Pausando música...");
    }

    @Override
    public void selecionarMusica(String musica) {
        System.out.println("Selecionando a música: " + musica);
    }

    // Implementação dos métodos para Aparelho Telefônico
    @Override
    public void ligar(String numero) {
        System.out.println("Ligando para " + numero);
    }

    @Override
    public void atender() {
        System.out.println("Atendendo chamada...");
    }

    @Override
    public void iniciarCorreioDeVoz() {
        System.out.println("Iniciando correio de voz...");
    }

    // Implementação dos métodos para Navegador na Internet
    @Override
    public void exibirPagina(String url) {
        System.out.println("Exibindo página da web: " + url);
    }

    @Override
    public void adicionarNovaAba() {
        System.out.println("Adicionando nova aba do navegador.");
    }

    @Override
    public void atualizarPagina() {
        System.out.println("Atualizando a página atual.");
    }

    public static void main(String[] args) {
        // Exemplo de uso do iPhone
        IPhone iphone = new IPhone();
        
        // Reprodutor Musical
        iphone.selecionarMusica("Canção 1");
        iphone.tocar();
        iphone.pausar();
        
        // Aparelho Telefônico
        iphone.ligar("123-456-789");
        iphone.atender();
        iphone.iniciarCorreioDeVoz();
        
        // Navegador na Internet
        iphone.exibirPagina("https://www.example.com");
        iphone.adicionarNovaAba();
        iphone.atualizarPagina();
    }
}
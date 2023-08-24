using PortfolioMvc.Models;

namespace PortfolioMvc.Services
{
    public class ProjetosService : IProjetosService
    {
        public List<Projeto> GetProjetos()
        {
            return new List<Projeto>() {
                    new Projeto
                {
                    Titulo = "Quiz Project",
                    Descricao = "Project in C# that aims to test knowledge on topics related to technology.",
                    Link = "https://www.linkedin.com/feed/update/urn:li:activity:7092267502352670720/",
                    ImagemURL = "/imagens/quizproject.png"
                },
                    new Projeto
                {
                    Titulo = "Finance",
                    Descricao = "Allows you to add and delete financial accounts, facilitating the management and control of personal finances",
                    Link = "https://github.com/eduardoaalmeidaa/Finance/",
                    ImagemURL = "/imagens/finance.png"
                },
                    new Projeto
                {
                    Titulo = "Resumes in the Cloud",
                    Descricao = "Resume site focused on experiences and skills related to Amazon Web Services (AWS)",
                    Link = "https://www.linkedin.com/posts/eduardoaalmeidaa_cloud-aws-activity-7087977161717866496-fUVn/?utm_source=share&utm_medium=member_desktop",
                    ImagemURL = "/imagens/curriculosnanuvem.png"
                },
                    new Projeto
                {
                    Titulo = "Digital Watch",
                    Descricao = "Project developed in Html-Css-JavaScript. Displays the current time in digital format, with hours, minutes and seconds. Automatically updated every second",
                    Link = "https://github.com/eduardoaalmeidaa/Digital-Watch",
                    ImagemURL = "/imagens/digitalwatch.png"
                },
            };
        }
    }
}

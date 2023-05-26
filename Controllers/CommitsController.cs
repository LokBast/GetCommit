using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using URALSIB.Models; // Импортируйте модели данных

namespace URALSIB.Controllers
{
    public class CommitsController : Controller
    {
        private readonly ILogger<CommitsController> _logger;
        private readonly dbContextUralsib _dbContext; // Замените "YourDbContext" на ваш контекст базы данных

        public CommitsController(ILogger<CommitsController> logger, dbContextUralsib dbContext) // Замените "YourDbContext" на ваш контекст базы данных
        {
            _logger = logger;
            _dbContext = dbContext;
        }


        private readonly GitHubService _gitHubService;

        public CommitsController(GitHubService gitHubService)
        {
            _gitHubService = gitHubService;
        }

        // Метод, который будет вызываться для импорта коммитов
        public async Task<IActionResult> ImportCommits(string owner, string repo, string token)
        {
            List<Commit> commits = await _gitHubService.GetCommits(owner, repo, token);

            // Здесь вы можете сохранить коммиты в базу данных или выполнять другую логику обработки

            return View(commits);
        }
        // Добавьте методы действий для обработки запросов пользователя
    }

    //public IActionResult Index()
    //{
    //    var commits = _dbContext.Commits.ToList(); // Получение списка коммитов из базы данных

    //    return View(commits);
    //}
}

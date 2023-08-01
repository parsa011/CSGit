using LibGit2Sharp;

namespace CSGit.Commands
{
    public class LogCommand
    {
        private readonly Repository _repo;

        public LogCommand(Repository repo)
        {
            _repo = repo;
        }

        public List<string> GetLog(int skip, int take)
        {
            var commits = _repo.Commits.Skip(skip).Take(take);
            return commits.Select(commit => CommitToString(commit)).ToList();
        }

        public string CommitToString(Commit commit)
        {
            string str = "";
            str += "Author : " + commit.Author.Name;
            str += " --- Message: " + commit.MessageShort;
            return str;
        }
    }
}

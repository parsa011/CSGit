using LibGit2Sharp;

namespace CSGit.Commands
{
	public class CSGitManager
	{
		private Repository _repo; 

		public readonly LogCommand Logs;
		public readonly BranchCommand Branches;
		

		public CSGitManager(string repoAddress)
		{
			_repo = new Repository(repoAddress);
            Logs = new LogCommand(_repo);
			Branches = new BranchCommand(_repo);
		}
	}
}

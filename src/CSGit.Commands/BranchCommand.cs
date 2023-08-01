using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGit.Commands
{
    public class BranchCommand
    {
        private readonly Repository _repo;
        public BranchCommand(Repository repo)
        {
            _repo = repo;
        }

        public List<string> GetBranches(Func<Branch, bool>? predicate)
        {
            var branches = _repo.Branches.ToList();
            if (predicate != null)
                branches = branches.Where(predicate).ToList();
            return branches.Select(branch => BranchToString(branch)).ToList();
        }

        public string BranchToString(Branch branch)
        {
            string str = "";
            str += $"Name: {branch.FriendlyName}";
            str += $"\tRemote: {branch.RemoteName}";
            str += $"\tCommits: {branch.Commits.Count()}";
            return str;
        }
    }
}

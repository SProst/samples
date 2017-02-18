using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace CleanViewModels
{
    public interface IBlogViewModel
    {
        ReactiveList<string> Articles { get; }
        Uri FeedAddress { get; }
        bool IsLoading { get; }
        ReactiveCommand<Unit, Unit> Refresh { get; }
        string Title { get; }
    }
}

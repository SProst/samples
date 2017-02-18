using ReactiveUI;
using System;
using System.Reactive;

namespace CleanViewModels
{
    public class WithoutFody : ReactiveObject, IBlogViewModel
    {
        public ReactiveCommand<Unit, Unit> Refresh { get; }

        public ReactiveList<string> Articles { get; }

        private Uri _feedAddress;
        public Uri FeedAddress
        {
            get { return _feedAddress; }
            private set { this.RaiseAndSetIfChanged(ref _feedAddress, value); }
        }

        private readonly ObservableAsPropertyHelper<bool> _isLoading;
        public bool IsLoading
        {
            get { return _isLoading.Value; }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            private set { this.RaiseAndSetIfChanged(ref _title, value); }
        }
    }
}
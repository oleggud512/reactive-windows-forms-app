using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.utils
{
    public class StateObservable<T> : IObservable<T>
    {
        private BehaviorSubject<T> stateSubject;

        public StateObservable(T initialState)
        {
            stateSubject = new BehaviorSubject<T>(initialState);
        }

        public T State { get => stateSubject.Value; protected set { stateSubject.OnNext(value); } }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            return stateSubject.AsObservable().Subscribe(observer);
        }
    }
}

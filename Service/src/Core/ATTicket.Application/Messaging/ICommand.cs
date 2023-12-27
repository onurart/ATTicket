namespace ATTicket.Application.Messaging;
public interface ICommand<out TResponse>:IRequest<TResponse>{}
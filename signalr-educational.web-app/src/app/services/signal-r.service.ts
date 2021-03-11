import { Injectable } from '@angular/core';
import * as signalR from '@aspnet/signalr';
import { HubConnection } from '@aspnet/signalr';
import { LogDto } from '../DataTransferObjects/log-dto';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class SignalRService {
  private hubConnection: HubConnection;
  private logsReceivedSource = new Subject<LogDto[]>();
  onLogsReceived = this.logsReceivedSource.asObservable();

  constructor() {
  }

  startConnection(): void {
    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl('https://localhost:5001/log')
      .build();

    this.hubConnection
      .start()
      .then(() => console.log('Successfully connection.'))
      .catch((err) => console.log('Error has occurred. ' + err));
  }

  onTransferLogs(): void {
    this.hubConnection.on('transfer-logs', (logs: LogDto[]) => {
      this.logsReceivedSource.next(logs);
    });
  }
}

import { Component, OnInit } from '@angular/core';
import { SignalRService } from './services/signal-r.service';
import { LogDto } from './DataTransferObjects/log-dto';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  logs: LogDto[];

  constructor(public signalRService: SignalRService) {
    this.logs = [];
  }

  ngOnInit(): void {
    this.signalRService.startConnection();
    this.signalRService.onTransferLogs();

    this.signalRService.onLogsReceived.subscribe(logs => {
      this.logs = this.logs.concat(logs);
    })
  }
}

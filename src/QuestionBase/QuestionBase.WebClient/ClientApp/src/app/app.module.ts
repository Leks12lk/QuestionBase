import { BrowserModule } from '@angular/platform-browser';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { SharedModule } from './shared/shared.module';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    SharedModule
  ],
  providers: [],
  bootstrap: [AppComponent],
  // schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class AppModule {
	// constructor(private ngRedux: NgRedux<IAppState>, private devTools: DevToolsExtension) {
	// 	let enhancers = [];

	// 	if (isDevMode()) {
	// 		enhancers.push(devTools.enhancer());
	// 		//Can't run  build in Prod Mode due to bug in Typescript. For now you can uncomment for development purposes, but shoud comment it for deployment
	// 		// thus disabling enhancer for deploying, otherwise will fail because not everyone has ReduxDevTools installed in their browsers
	// 	}

	// 	ngRedux.configureStore(rootReducer, INITIAL_STATE, null, enhancers);
	// }

}

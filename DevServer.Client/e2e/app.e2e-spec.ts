import { DevServer.ClientPage } from './app.po';

describe('dev-server.client App', () => {
  let page: DevServer.ClientPage;

  beforeEach(() => {
    page = new DevServer.ClientPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

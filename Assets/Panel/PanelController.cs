namespace Panel
{
    public class PanelController
    {
        private readonly PanelView.Pool _pool;
        private readonly PanelConfig _panelConfig;

        public PanelController(
            PanelView.Pool pool,
            PanelConfig panelConfig)
        {
            _pool = pool;
            _panelConfig = panelConfig;
        }

        public PanelView Spawn()
        {
            return _pool.Spawn(_panelConfig.PanelImageModels);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mosaic4.Entities {
	public class MosaicProject {
		private string _originalPath;
		private string _tilesPath;
		private int _tileWidth;
		private int _tileHeight;
		private string _finalPath;
		private int _finalWidth;
		private int _finalHeight;

		public string OriginalPath {
			get {
				return _originalPath;
			}

			set {
				_originalPath = value;
			}
		}

		public string TilesPath {
			get {
				return _tilesPath;
			}

			set {
				_tilesPath = value;
			}
		}

		public int TileWidth {
			get {
				return _tileWidth;
			}

			set {
				_tileWidth = value;
			}
		}

		public int TileHeight {
			get {
				return _tileHeight;
			}

			set {
				_tileHeight = value;
			}
		}

		public string FinalPath {
			get {
				return _finalPath;
			}

			set {
				_finalPath = value;
			}
		}

		public int FinalWidth {
			get {
				return _finalWidth;
			}

			set {
				_finalWidth = value;
			}
		}

		public int FinalHeight {
			get {
				return _finalHeight;
			}

			set {
				_finalHeight = value;
			}
		}
	}
}

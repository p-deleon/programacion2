public class clsBeTiposEntidades : ICloneable {

	private int mIdTipoEntidad = 0;
	private string mTEDescripcion = '';
	private int mIdGrupoEntidad = 0;
	private string mComentario = '';
	private string mEstatus = '';
	private bool mNoEliminable = False;
	private String mFechaRegistro = ;

	public Integer IdTipoEntidad {
		get {
			return mIdTipoEntidad;
		}
		set {
			mIdTipoEntidad = value;
		}
	}

	public String TEDescripcion {
		get {
			return mTEDescripcion;
		}
		set {
			mTEDescripcion = value;
		}
	}

	public Integer IdGrupoEntidad {
		get {
			return mIdGrupoEntidad;
		}
		set {
			mIdGrupoEntidad = value;
		}
	}

	public String Comentario {
		get {
			return mComentario;
		}
		set {
			mComentario = value;
		}
	}

	public String Estatus {
		get {
			return mEstatus;
		}
		set {
			mEstatus = value;
		}
	}

	public Boolean NoEliminable {
		get {
			return mNoEliminable;
		}
		set {
			mNoEliminable = value;
		}
	}

	public String FechaRegistro {
		get {
			return mFechaRegistro;
		}
		set {
			mFechaRegistro = value;
		}
	}

	TiposEntidades(){
	}

	TiposEntidades(){ref int IdTipoEntidad, string TEDescripcion, int IdGrupoEntidad, string Comentario, string Estatus, bool NoEliminable, String FechaRegistro)
		mIdTipoEntidad = IdTipoEntidad;
		mTEDescripcion = TEDescripcion;
		mIdGrupoEntidad = IdGrupoEntidad;
		mComentario = Comentario;
		mEstatus = Estatus;
		mNoEliminable = NoEliminable;
		mFechaRegistro = FechaRegistro;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}

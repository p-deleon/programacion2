public class clsBeGruposEntidades : ICloneable {

	private int mIdGrupoEntidad = 0;
	private string mDEDescripcion = '';
	private string mComentario = '';
	private string mEstatus = '';
	private bool mNoEliminable = False;
	private String mFechaRegistro = ;

	public Integer IdGrupoEntidad {
		get {
			return mIdGrupoEntidad;
		}
		set {
			mIdGrupoEntidad = value;
		}
	}

	public String DEDescripcion {
		get {
			return mDEDescripcion;
		}
		set {
			mDEDescripcion = value;
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

	GruposEntidades(){
	}

	GruposEntidades(){ref int IdGrupoEntidad, string DEDescripcion, string Comentario, string Estatus, bool NoEliminable, String FechaRegistro)
		mIdGrupoEntidad = IdGrupoEntidad;
		mDEDescripcion = DEDescripcion;
		mComentario = Comentario;
		mEstatus = Estatus;
		mNoEliminable = NoEliminable;
		mFechaRegistro = FechaRegistro;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
